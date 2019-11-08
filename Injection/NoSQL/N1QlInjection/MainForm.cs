using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Couchbase;
using Couchbase.N1QL;

namespace N1QlInjection
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            ClusterHelper.Initialize();
        }

        private void btnWhereUnsafe_Click(object sender, EventArgs e)
        {
            RunQuery("SELECT * FROM `beer-sample` WHERE type = 'beer' AND name LIKE '%" +
                     edtWhere.Text + "%' AND brewery_id = '21st_amendment_brewery_cafe'");
        }

        private void btnWhereSafe_Click(object sender, EventArgs e)
        {
            RunQuery("SELECT * FROM `beer-sample` WHERE type = 'beer' AND name LIKE '%" +
                     edtWhere.Text.Replace("'", "''") + "%' AND brewery_id = '21st_amendment_brewery_cafe'");
        }

        private void btnWhereSafeParam_Click(object sender, EventArgs e)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "$name", "%" + edtWhere.Text + "%" }
            };

            RunQuery("SELECT * FROM `beer-sample` WHERE type = 'beer' AND name LIKE $name " +
                     "AND brewery_id = '21st_amendment_brewery_cafe'", parameters);

        }

        private void btnCommentUnsafe_Click(object sender, EventArgs e)
        {
            RunQuery("SELECT * FROM `beer-sample` WHERE type = 'beer' AND name LIKE '%" +
                     edtComment.Text + "%' AND brewery_id = '21st_amendment_brewery_cafe' /* 21st century only */");
        }

        private void btnCommentSafe_Click(object sender, EventArgs e)
        {
            RunQuery("SELECT * FROM `beer-sample` WHERE type = 'beer' AND name LIKE '%" +
                     edtComment.Text.Replace("'", "''") + "%' AND brewery_id = '21st_amendment_brewery_cafe'"); // 21st century only
        }

        private void btnIdentifierUnsafe_Click(object sender, EventArgs e)
        {
            RunQuery("SELECT " + edtIdentifier.Text + " FROM `beer-sample` " + 
                     "WHERE type = 'beer' AND brewery_id = '21st_amendment_brewery_cafe'");
        }

        private void btnIdentifierSafe_Click(object sender, EventArgs e)
        {
            RunQuery("SELECT `" + edtIdentifier.Text.Replace("`", "``") + "` FROM `beer-sample` " +
                     "WHERE type = 'beer' AND brewery_id = '21st_amendment_brewery_cafe'");
        }

        private void RunQuery(string query, IDictionary<string,object> parameters = null)
        {
            edtResults.Text = query + "\r\n\r\nRunning...";
            tabControl.Enabled = false;

            Task.Run(async () =>
            {
                var bucket = ClusterHelper.GetBucket("beer-sample");

                var queryRequest = new QueryRequest(query);
                
                if (parameters != null)
                {
                    queryRequest.AddNamedParameter(parameters.ToArray());
                };

                var result = await
                    bucket.QueryAsync<dynamic>(queryRequest);
                if (!result.Success)
                {
                    if (result.Errors != null && result.Errors.Count > 0)
                    {
                        return result.Errors.First().Message;
                    }
                    else if (result.Exception != null)
                    {
                        return string.Format("{0}\r\n\r\n{1}\r\n{2}", query, result.Exception.Message,
                            result.Exception.StackTrace);
                    }
                    else
                    {
                        return "Unknown Error";
                    }
                }
                else if (result.Rows != null)
                {
                    var sb = new StringBuilder();
                    sb.AppendFormat("{0}\r\n\r\n{1} rows returned\r\n\r\n", query, result.Rows.Count);

                    foreach (var row in result.Rows)
                    {
                        sb.AppendLine(row.ToString());
                    }

                    return sb.ToString();
                }
                else
                {
                    return query + "\r\n\r\n0 row returned";
                }
            })
                .ContinueWith(task =>
                {
                    BeginInvoke(new Action(() =>
                    {
                        if (task.IsFaulted)
                        {
                            edtResults.Text = string.Format("{0}\r\n\r\n{1}\r\n{2}", query, task.Exception.Message,
                                task.Exception.StackTrace);
                        }
                        else
                        {
                            edtResults.Text = task.Result;
                        }

                        tabControl.Enabled = true;
                    }));
                });
        }
    }
}
