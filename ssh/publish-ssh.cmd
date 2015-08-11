SET USER=edocsys
SET PWD=po12jein45bf
SET HOST=kisp.no-ip.org
SET PORT=22
SET PUBLISHDIR=../src/Edocsys/Edocsys/publish

plink.exe -pw %PWD% -batch -v -P %PORT% %USER%@%HOST% `export BUDATE=\`date +%%y-%%m-%%d-%%H-%%M\` ; mkdir /opt/edocsys/updates/backup-$BUDATE ; mv /opt/edocsys/updates/lastest/* /opt/edocsys/updates/backup-$BUDATE`
pscp.exe  -pw %PWD% -batch -v -sftp -P %PORT% -r %PUBLISHDIR%/* %USER%@%HOST%:/opt/edocsys/updates/lastest/
