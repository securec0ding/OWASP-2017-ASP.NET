namespace N1QlInjection
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.edtWhere = new System.Windows.Forms.TextBox();
            this.btnWhereSafe = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.edtResults = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnWhereUnsafe = new System.Windows.Forms.Button();
            this.btnCommentUnsafe = new System.Windows.Forms.Button();
            this.edtComment = new System.Windows.Forms.TextBox();
            this.btnCommentSafe = new System.Windows.Forms.Button();
            this.btnIdentifierUnsafe = new System.Windows.Forms.Button();
            this.edtIdentifier = new System.Windows.Forms.TextBox();
            this.btnIdentifierSafe = new System.Windows.Forms.Button();
            this.btnWhereSafeParam = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // edtWhere
            // 
            this.edtWhere.AcceptsReturn = true;
            this.edtWhere.AcceptsTab = true;
            this.edtWhere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtWhere.Location = new System.Drawing.Point(0, 0);
            this.edtWhere.Multiline = true;
            this.edtWhere.Name = "edtWhere";
            this.edtWhere.Size = new System.Drawing.Size(748, 103);
            this.edtWhere.TabIndex = 0;
            this.edtWhere.Text = "\' OR \'\'=\'";
            // 
            // btnWhereSafe
            // 
            this.btnWhereSafe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWhereSafe.Location = new System.Drawing.Point(470, 109);
            this.btnWhereSafe.Name = "btnWhereSafe";
            this.btnWhereSafe.Size = new System.Drawing.Size(133, 50);
            this.btnWhereSafe.TabIndex = 2;
            this.btnWhereSafe.Text = "&Safe";
            this.btnWhereSafe.UseVisualStyleBackColor = true;
            this.btnWhereSafe.Click += new System.EventHandler(this.btnWhereSafe_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(12, 213);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(55, 17);
            this.lblResults.TabIndex = 3;
            this.lblResults.Text = "Results";
            // 
            // edtResults
            // 
            this.edtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtResults.Location = new System.Drawing.Point(73, 213);
            this.edtResults.Multiline = true;
            this.edtResults.Name = "edtResults";
            this.edtResults.ReadOnly = true;
            this.edtResults.Size = new System.Drawing.Size(757, 401);
            this.edtResults.TabIndex = 4;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(74, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(756, 194);
            this.tabControl.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnWhereSafeParam);
            this.tabPage1.Controls.Add(this.btnWhereUnsafe);
            this.tabPage1.Controls.Add(this.edtWhere);
            this.tabPage1.Controls.Add(this.btnWhereSafe);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(748, 165);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Where Clause";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCommentUnsafe);
            this.tabPage2.Controls.Add(this.edtComment);
            this.tabPage2.Controls.Add(this.btnCommentSafe);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(748, 165);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comment";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnIdentifierUnsafe);
            this.tabPage3.Controls.Add(this.edtIdentifier);
            this.tabPage3.Controls.Add(this.btnIdentifierSafe);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(748, 165);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Identifier";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnWhereUnsafe
            // 
            this.btnWhereUnsafe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWhereUnsafe.Location = new System.Drawing.Point(331, 109);
            this.btnWhereUnsafe.Name = "btnWhereUnsafe";
            this.btnWhereUnsafe.Size = new System.Drawing.Size(133, 50);
            this.btnWhereUnsafe.TabIndex = 1;
            this.btnWhereUnsafe.Text = "&Unsafe";
            this.btnWhereUnsafe.UseVisualStyleBackColor = true;
            this.btnWhereUnsafe.Click += new System.EventHandler(this.btnWhereUnsafe_Click);
            // 
            // btnCommentUnsafe
            // 
            this.btnCommentUnsafe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCommentUnsafe.Location = new System.Drawing.Point(470, 112);
            this.btnCommentUnsafe.Name = "btnCommentUnsafe";
            this.btnCommentUnsafe.Size = new System.Drawing.Size(133, 50);
            this.btnCommentUnsafe.TabIndex = 4;
            this.btnCommentUnsafe.Text = "&Unsafe";
            this.btnCommentUnsafe.UseVisualStyleBackColor = true;
            this.btnCommentUnsafe.Click += new System.EventHandler(this.btnCommentUnsafe_Click);
            // 
            // edtComment
            // 
            this.edtComment.AcceptsReturn = true;
            this.edtComment.AcceptsTab = true;
            this.edtComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtComment.Location = new System.Drawing.Point(0, 3);
            this.edtComment.Multiline = true;
            this.edtComment.Name = "edtComment";
            this.edtComment.Size = new System.Drawing.Size(748, 103);
            this.edtComment.TabIndex = 3;
            this.edtComment.Text = "\' OR 1=1 /*";
            // 
            // btnCommentSafe
            // 
            this.btnCommentSafe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCommentSafe.Location = new System.Drawing.Point(609, 112);
            this.btnCommentSafe.Name = "btnCommentSafe";
            this.btnCommentSafe.Size = new System.Drawing.Size(133, 50);
            this.btnCommentSafe.TabIndex = 5;
            this.btnCommentSafe.Text = "&Safe";
            this.btnCommentSafe.UseVisualStyleBackColor = true;
            this.btnCommentSafe.Click += new System.EventHandler(this.btnCommentSafe_Click);
            // 
            // btnIdentifierUnsafe
            // 
            this.btnIdentifierUnsafe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIdentifierUnsafe.Location = new System.Drawing.Point(470, 112);
            this.btnIdentifierUnsafe.Name = "btnIdentifierUnsafe";
            this.btnIdentifierUnsafe.Size = new System.Drawing.Size(133, 50);
            this.btnIdentifierUnsafe.TabIndex = 4;
            this.btnIdentifierUnsafe.Text = "&Unsafe";
            this.btnIdentifierUnsafe.UseVisualStyleBackColor = true;
            this.btnIdentifierUnsafe.Click += new System.EventHandler(this.btnIdentifierUnsafe_Click);
            // 
            // edtIdentifier
            // 
            this.edtIdentifier.AcceptsReturn = true;
            this.edtIdentifier.AcceptsTab = true;
            this.edtIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtIdentifier.Location = new System.Drawing.Point(0, 3);
            this.edtIdentifier.Multiline = true;
            this.edtIdentifier.Name = "edtIdentifier";
            this.edtIdentifier.Size = new System.Drawing.Size(748, 103);
            this.edtIdentifier.TabIndex = 3;
            this.edtIdentifier.Text = "name, (SELECT * FROM `beer-sample` as sample2 USE KEYS `beer-sample`.brewery_id) " +
    "as brewery";
            // 
            // btnIdentifierSafe
            // 
            this.btnIdentifierSafe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIdentifierSafe.Location = new System.Drawing.Point(609, 112);
            this.btnIdentifierSafe.Name = "btnIdentifierSafe";
            this.btnIdentifierSafe.Size = new System.Drawing.Size(133, 50);
            this.btnIdentifierSafe.TabIndex = 5;
            this.btnIdentifierSafe.Text = "&Safe";
            this.btnIdentifierSafe.UseVisualStyleBackColor = true;
            this.btnIdentifierSafe.Click += new System.EventHandler(this.btnIdentifierSafe_Click);
            // 
            // btnWhereSafeParam
            // 
            this.btnWhereSafeParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWhereSafeParam.Location = new System.Drawing.Point(609, 109);
            this.btnWhereSafeParam.Name = "btnWhereSafeParam";
            this.btnWhereSafeParam.Size = new System.Drawing.Size(133, 50);
            this.btnWhereSafeParam.TabIndex = 3;
            this.btnWhereSafeParam.Text = "&Safe Param";
            this.btnWhereSafeParam.UseVisualStyleBackColor = true;
            this.btnWhereSafeParam.Click += new System.EventHandler(this.btnWhereSafeParam_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 626);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.edtResults);
            this.Controls.Add(this.lblResults);
            this.Name = "MainForm";
            this.Text = "N1QL Injection Sample";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnWhereSafe;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.TextBox edtResults;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnWhereUnsafe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox edtWhere;
        private System.Windows.Forms.Button btnCommentUnsafe;
        private System.Windows.Forms.TextBox edtComment;
        private System.Windows.Forms.Button btnCommentSafe;
        private System.Windows.Forms.Button btnIdentifierUnsafe;
        private System.Windows.Forms.TextBox edtIdentifier;
        private System.Windows.Forms.Button btnIdentifierSafe;
        private System.Windows.Forms.Button btnWhereSafeParam;
    }
}

