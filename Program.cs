// See https://aka.ms/new-console-template for more information
using GuidanceFacebookAPI;

DateTime startDate = new DateTime(2023,7,9);
DateTime endDate = new DateTime(2023, 7, 31);

for(int i = 0; i<= (endDate - startDate).Days; i++)
{
    DateTime currentDay = startDate.AddDays(i);
    string guidanceForDay = FileReader.GuidanceForGivenDate(currentDay.Month, currentDay.Day);
    
}
