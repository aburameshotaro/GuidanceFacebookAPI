// See https://aka.ms/new-console-template for more information
using GuidanceFacebookAPI;

var startup = new Startup();
DateTime startDate = new DateTime(2023,8,8, 17, 0, 0);
DateTime endDate = new DateTime(2023, 12, 31, 17, 0, 0);
FacebookApi api = new FacebookApi();
api.PageAccessToken = startup.ApiSettings.PageAccessToken;

for (int i = 0; i<= (endDate - startDate).Days; i++)
{
    DateTime currentDay = startDate.AddDays(i);
    string guidanceForDay = FileReader.GuidanceForGivenDate(currentDay.Month, currentDay.Day);
    await api.PostMessage(startup.ApiSettings.FacebookPageId, guidanceForDay, currentDay);

}
