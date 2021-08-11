# David Kuehn's Sportradar Api challenge
> Built using a .Net Core API

To build this solution, simply clone the project, build and run via VisualStudio2019.  A web browser should open via IISExpress with the API's swagger page as the default page.  You can use this interface to click "Try it out" via the Swagger UI and provide a teamId and year.  Clicking "Execute" will send a GET to the api and you should be able to download the resulting file via a "Download File" button below "Responses" near the 200 Response code text.

Alternatively, you can build a URI such as https://localhost:44353/Pipeline/Teams?teamId=30&seasonYear=2017 and navigate there via a browser and you should be returned the file as well.

This project features 20 tests that ensure the API models accurately serialize and the Team and Schedule data is transformed appropriatley to fit the data pipeline.


# sportradar-api-challenge
 > combine data form nhl apis to create csv files

 Build an ETL pipeline based on NHL APIs. The separation of concerns, number of functions, and general approach is entirely up to you. The following functionality is required.

* **Team Pipeline** - Provide a team id and season year which outputs a CSV file. The CSV should include the following:
  * Team ID
  * Team Name
  * Team Venue Name
  * Games Played
  * Wins
  * Losses
  * Points
  * Goals Per Game
  * Game Date of First Game of Season
  * Opponent Name in First Game of Season
* **Player Pipeline** - Provide a player id and season year which outputs a CSV file. The CSV should include the following:
  * Player ID
  * Player Name
  * Current Team
  * Player Age
  * Player Number
  * Player Position
  * If the player is a rookie
  * Assists
  * Goals
  * Games
  * Hits
  * Points

This exercise is in-lieu of a traditional whiteboard/algorithm style type interview. Not only will this exercise serve as our initial evaluation of your development skills, it will also be a center-piece to further conversations we will have with you. We respect your time and the fact that you have a life and possibly a day-job, so put in as much time as you feel will be a fair representation of your skills.  However, this exercise is purposefully open ended and can be an opportunity for you to show off. Hopefully this is something you can have fun with.

While the approach you take to meeting the above objectives is up to you, here are a couple of things we will expect:

* There should be a basic README included.
* There should be tests.
* We should be able to run this locally (provide instructions if need be).

Please do not create a pull-request against this repository; you should create your own project/repository.  Also--while not required--it would be nice to have access to your commit history (i.e. don't squash) through github. However if you are not comfortable with this for any reason, submitting a zip file with the contents of the project is acceptable as well.
