# Overview

[SQL Injection](https://en.wikipedia.org/wiki/SQL_injection) is a well known security concern when working with SQL servers.
Since [Couchbase](http://couchbase.com) has added N1QL to the NoSQL environment, how does SQL injection translate to N1QL injection?
This simple test application can be used to demonstrate potential N1QL injection attacks.

# Instructions

Install Couchbase Server on your local machine, and choose to load the "beer-sample" sample data.  Then compile and run the application.

Each tab is preloaded with a different possible attack.  These attacks would allow access to data that the developer did not intend.
There is a button for each attack, one the unsafe version and the other the safe version.  You can easily compare the results
to see how the preventative measure works for each attack.

# Preventative Measures

* Use named or positional parameters instead of inserting user input directly into the query
* If inserted user input directly into the query, escape single quotes in user input strings (') with a pair of single quotes ('')
* Remove comments from the query and place in code instead (this is an additional layer of protection)
* Escape N1QL identifiers with ticks and escape ticks in user input with a pair of ticks
