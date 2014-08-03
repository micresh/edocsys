@echo off

REM Set path to mysql
SET PATH=%PATH%;d:\devel\MySQL\MySQL Server 5.5\bin\

REM Set datetime for dump filename
set year=%date:~-4%
set month=%date:~-7,2%
set day=%date:~-10,2%
SET time=%TIME%
SET time=%time: =0%
SET time=%time::=%
SET time=%time:,=%
set hour=%time:~-8,2%
set minute=%time:~-6,2%
set sec=%time:~-4,2%
set timest=%year%-%month%-%day%_%hour%.%minute%.%sec%

REM Set dump filename
set dumpfile=dump-doc_templates-%timest%.sql

REM Run mysql dump
mysqldump.exe --lock-tables=FALSE --add-locks=FALSE --default-character-set=utf8 --max_allowed_packet=1G --host=localhost --extended-insert=FALSE --user=root --password=po12jein45bf --hex-blob=TRUE --complete-insert=TRUE --replace=TRUE --port=3309 --single-transaction=TRUE "edocbase" "doc_templates" > %dumpfile%