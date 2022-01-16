# Custom Dotnet Templates

### Contains various custom project templates:

* Dotnet Templates
	* It can be installed by running "dotnet new --install ." in the parent directory of the .template.config folder. Change the "." to the location of the parent directory of .template.config if not running from the parent directory already.
	* It can also be installed by generating a nuget package from a csproj "dotnet pack projectFile.csproj" that encapsulates all the project templates and installing the generated nuget package "dotnet new --install nugetPackage.nupkg".
	* To view the installed template run "dotnet new --list".
	* It can be uninstall by running "dotnet new --unistall .".
	* Schema: http://json.schemastore.org/template
	* Compatible for Visual Studio 2022.

* Extensions
	* A template for creating various files such as .cs, .vb, .json, .config etc.
	* https://github.com/dotnet/templating/wiki/Reference-for-template.json

* Web Application Template
	* A custom Web Api template.
	* Example templates:
		* https://github.com/sayedihashimi/template-sample
		* https://github.com/dotnet/aspnetcore/tree/v5.0.0/src/ProjectTemplates
		* https://dotnetnew.azurewebsites.net/
		* https://www.nuget.org/
		* https://www.nuget.org/packages/Boxed.Templates/
		* Run "dotnet new --search"

* Issues with cached Dotnet templates
	* Uninstall template and then navigate to "C:\Users\{logged in user}\.templateengine" and delete files and folders.
	* Reinstall the template and run "dotnet new --debug:rebuildcache".
	* Make sure to close Visual Studio before doing any of the above.
	* More issues and fixes can be found at https://github.com/sayedihashimi/template-sample.
	
* VS Templates
	* VS Templates is an old format for creating custom project templates in older versions of Visual Studio.
		* Supports Visual Studio 2019 and older.
	* There is 2 ways for creating these templates namely:
		* Create a project as normal off an existing template and make additional changes as required. Once completed, In Visual Studio go to Project -> Export Template to generate the VS Template. Go to C:\Users\dummyUser\Documents\Visual Studio 2022\My Exported Templates and copy the generated zip file to the appropriate folder eg. C:\Users\dummyuser\Documents\Visual Studio 2022\Templates\ItemTemplates\Visual C#
		* Create a project as normal off an existing template and make additonal changes as required. Make a copy of the edited project and alter the project with variables using VS Templates syntax. eg. the namespace for all files.
			* The edited project is used so that the developer can confirm that the project builds.
			* The copy of the edited project with the VS Templates variables syntax is used as the template which Visual Studio will use.
			* The above solution can all be done by creating a template project and making the appropriate changes. This project will create the template zip file when built which can be put into the appropriate templates folder to then be used by Visual Studio.
	* For templates imported into Visual Studio 2019 or earlier, Visual Studio will need to be reloaded to pick up the new template.