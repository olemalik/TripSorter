# TripSorter

## Task
You are given a stack of boarding cards for various transportations that will take you from a point A to point B via several stops on the way. All of the boarding cards are out of order, and you don't know where your journey starts, nor where it ends. Each boarding card contains information about seat assignment, and means of transportation (such as flight number, bus number etc.) Write an API that lets you sort this kind of list and present back a description of how to complete your journey. For instance, the API should be able to take an unordered set of boarding cards, provided in a format defined by you, and produce this list:
1. Take train 78A from Madrid to Barcelona. Sit in seat 45B.
2. Take the airport bus from Barcelona to Gerona Airport. No seat assignment.
3. From Gerona Airport, take flight SK455 to Stockholm. Gate 45B, seat 3A.
4. Baggage drops at ticket counter 344.
5. From Stockholm, take flight SK22 to New York JFK. Gate 22, seat 7B.
6. Baggage will we automatically transferred from your last leg.
7. You have arrived at your final destination.
The list should be defined in a format that's compatible with the input format. The API is to be an internal ASP.NET (C#) API so it will only communicate with other parts of a .NET application, not server to server, nor server to client. Use txt file(s) to document the input your API, and output should be displayed as a listing page in HTML.

## How to run the code
1. Since the development is done using .NET6, Visual Studio 2022 is requeed.
2. In the main repository folder,open the TripSorter.sln
3. Before you run the appication , you nedd to set mutpiple startup projects as TripSort.UI and TripSorter
4. Hit the play button to run
5. When the build is suucess two tabs will be opened, one is the WebAPi Swagger and other is the user interface(UI)
6. In the UI tab you should be able to see the boarding passess with a carouse.

## How to run the unit test
1. Stop the visual studio, if it is in running state 
2. From the visual studio nsvigate to TripSort.UnitTesst project
3. Under the TripSort.UnitTesst project open the TranslportAPIUnitTest class file
4. Right click anywhere inside a particular method in the class and click Run Test to do a unit test. To run all the tests you need to open the Test Explorer from the visual studio top ribbon.
