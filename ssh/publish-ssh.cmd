SET USER=edocsys
SET PWD=po12jein45bf
SET HOST=kisp.no-ip.org
SET PORT=22
SET PUBLISHDIR=../src/Edocsys/Edocsys/publish
plink.exe -pw %PWD% -batch -v -P %PORT% %USER%@%HOST% `mkdir /opt/edocsys/updates/backup-\`date +%%y-%%m-%%d-%%H-%%M\``
plink.exe -pw %PWD% -batch -v -P %PORT% %USER%@%HOST% `mv /opt/edocsys/updates/lastest/* /opt/edocsys/updates/backup-\`date +%%y-%%m-%%d-%%H-%%M\``
pscp.exe  -pw %PWD% -batch -v -sftp -P %PORT% -r %PUBLISHDIR%/* %USER%@%HOST%:/opt/edocsys/updates/lastest/
