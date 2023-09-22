How to use?

	1. Run AutoRunApp.exe (Squirrel.dll must be in the same folder, it support to create shortcut)

	2. Settings parameters
	   - Parameter values are saved in the settings.ini file.
	   - The Save button on the main Form is used to save the main Form parameters.
           - The Save button on the setting Form is used to save the settings Form parameters. 

        3. Restart the computer to test.



AutoRunApp workflow:

	1. Check the network connection.
	2. Check the local SQL server connection.
	3. Launch the application

	- If the network and SQL connection is successful, the AutoRunApp window will be hidden as tray icon.
 	- If there are any issues with the network or SQL connection at Windows system start-up,
	  the AutoRunApp main Form will pop up.
        - The Setting Form will pop up when AutoRunApp.exe run at first time.