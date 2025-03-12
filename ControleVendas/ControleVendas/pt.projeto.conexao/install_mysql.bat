@echo off

rem Caminho para o instalador do MySQL
set MYSQL_INSTALLER=mysql-installer-community-8.0.23.0.msi

rem Usuário e senha do MySQL
set MYSQL_USER=root
set MYSQL_PASSWORD=12345

rem Instalar o MySQL silenciosamente
msiexec /i %MYSQL_INSTALLER% /quiet /qn /norestart /log install_mysql.log INSTALLDIR="C:\Program Files\MySQL" INSTALLSHORTCUTS=1

rem Configurar usuário e senha
"C:\Program Files\MySQL\MySQL Server 8.0\bin\mysql" -u root -e "ALTER USER '%MYSQL_USER%'@'localhost' IDENTIFIED BY '%MYSQL_PASSWORD%';"

echo MySQL foi instalado e configurado com sucesso.
