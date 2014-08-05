@echo off
SET user=root
SET pwd=po12jein45bf

mysql -u%user% -p%pwd% < createbase.sql
mysql -u%user% -p%pwd% < createusers.sql
mysql -u%user% -p%pwd% < datainsert.sql