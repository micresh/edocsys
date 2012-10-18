#! /bin/bash
user=root
password=po12jein45bf

mysql -u$user -p$password <createbase.sql
mysql -u$user -p$password <createusers.sql 
mysql -u$user -p$password <datainsert.sql
mysql -u$user -p$password <basedatainsert.sql
