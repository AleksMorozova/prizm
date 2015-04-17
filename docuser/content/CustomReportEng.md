# Configuring custom reports

## Configuring ODBC Data Source

* Open Control Panel - System and Security - Administrative Tools - ODBC Data Sources

![_ConfiguringODBCDataSource.png](./images/_ConfiguringODBCDataSource.png "")

Please start ODBC Data Sources (32-bit) or ODBC Data Sources (64-bit), depending on version of installed Microsoft Office.
If you have installed MS Office 32-bit then run ODBC Data Sources (32-bit)
If you have installed MS Office 64-bit then run ODBC Data Sources (64-bit)

*Note 1: Windows 7 displayes only 64-bit ODBC Data Sources. So if you have MS Office 32-bit on Windows 7, you should run the following command %windir%\SysWOW64\odbcad32.exe to configure 32-bit Data Sources:*

![_ConfiguringForWindows732bit.png](./images/_ConfiguringForWindows732bit.png "")

* Switch to **System DSN** tab and click **Add..** button

![_SystemDSN.png](./images/_SystemDSN.png "")


* Select **ODBC Driver 11 for SQL Server** and click **Finish**

![_CreateNewDataSource.png](./images/_CreateNewDataSource.png "")


Note 1: If you already have preinstalled ODBC driver it can be named as **SQL Server Native Client 11.0**

![_CreateNewDataSourceForPreinstalledDriver.png](./images/_CreateNewDataSourceForPreinstalledDriver.png "")

*Note 2: Please do not use driver with name “SQL Server”. Only “SQL Server Native Client 11.0” or “ODBC Driver 11 for SQL Server” should be used for successful linking.*

*  Please fill the Name of ODBC Data Source, Description and SQL Server:

![_CreateNewDataSourceStep2.png](./images/_CreateNewDataSourceStep2.png "")

*Important: SQL Server name must be (localdb)\v11.0 and Name with Description can be any strings.*


* Check that option **With Integrated Windows authenctication** is selected and click **Next** for the next step:

![_CreateNewDataSourceStep3.png](./images/_CreateNewDataSourceStep3.png "")

* Check **Change the default database to** checkbox and select Name of appropriate Database from the combobox:

![_CreateNewDataSourceStep4.png](./images/_CreateNewDataSourceStep4.png "")


Name of Database is the same as name of Project. You have specified name of Project during installation.

*Note 1: If SQL server was not started, it will be started automatically when you try to expand combobox. This process may take some time and you can receive timeout connection error. This is normal behaviour. Please try several times. When SQL server will be started, you will see list of all databases on your local server.*

* Check the following step against screenshot and click **Finish**

![_CreateNewDataSourceStep5.png](./images/_CreateNewDataSourceStep5.png "")

* Please click **Test Data Source…** to verify that process of creating Data Source was completed successfully and click **OK**

![_TestDataSource.png](./images/_TestDataSource.png "")

* Verify that newly created Data Source will appear in ODBC Sata Source Administator window:

![_VerifyNewlyCreatedDataSource.png](./images/_VerifyNewlyCreatedDataSource.png "")

##	Configuring MS Access

*Note: Language for Non-Unicode program should be the same as the language of Access interface.*

*Set up language for Non-Unicode program:*
*Control Panel – Clock, Language, and Region – Region – Administrative – Language for non-Unicode programs*

![_LanguageForNonUnicodeProgram.png](./images/_LanguageForNonUnicodeProgram.png "")


* Start MS Access and create new database. I will use MS Access 2013

* Open **External Data** ribbon and click **ODBC Database** menu item:

![_ConfigAccessStep1.png](./images/_ConfigAccessStep1.png "")

* Select option **Link to the data source by creating a linked table**

![_ConfigAccessStep2.png](./images/_ConfigAccessStep2.png "")

* New dialog window **Select Data Source** will be opened. Switch to **Machine Data Source** tab, then find and select your Data Source:

![_ConfigAccessSelectDataSource.png](./images/_ConfigAccessSelectDataSource.png "")

* Select tables you want to display in report and click **OK** button

![_ConfigAccessSelectTables.png](./images/_ConfigAccessSelectTables.png "")

* You will see added tables in the common tables list of Microsoft Access (I have just added Welder table):

![_ConfigAccessFinalResult.png](./images/_ConfigAccessFinalResult.png "")
 
