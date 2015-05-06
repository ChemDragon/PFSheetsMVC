# PFSheetsMVC

An ASP.NET MVC Project using Entity Framework 6.0

A web application to create Pathfinder Character Sheets and share them between members.



    To get the databases setup in VS2013, bring up the Package Manager Console and run:
        update-database -configurationtypename userconfiguration
        
    And then run:
        update-database -configurationtypename configuration
        
    These will do the initial migrations of the 2 db's in this project, the first being MVC's User Identity DB and the second being the DB's to actually be used for character sheet creation and editting. Any further changes to the models will require new migrations to be created and ran.
