ECHO off
REM Batch file to run a script to create database
REM Last updated: 3/25/2016
REM Uses the sqlcmd utility to run the sql script
REM
REM If this does not work, attempt to use: sqlcmd -S localhost\sqlexpress -E -i SCRIPT_NAME.sql
ECHO Begin running PCBuilder scripts:
sqlcmd -S localhost -E -i SQLCreateDB.sql
ECHO ------------------------------------------------------------------
ECHO If no error messages appear DB was created successfully
ECHO ------------------------------------------------------------------
ECHO.
sqlcmd -S localhost -E -i SQLProcedures.sql
ECHO ------------------------------------------------------------------
ECHO If no error messages appear Procedures were created successfully
ECHO ------------------------------------------------------------------
ECHO.
sqlcmd -S localhost -E -i SQLOriginalDBPopulationInserts.sql
ECHO ------------------------------------------------------------------
ECHO If no error messages appear Inserts were executed successfully 
ECHO ------------------------------------------------------------------
ECHO.
ECHO.
ECHO ------------------------------------------------------------------
ECHO If no error messages appear all scripts were executed successfully
ECHO ------------------------------------------------------------------
ECHO.
PAUSE