namespace Tests;

using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Return_A_List_Of_Strings_Containing_The_Three_String_Parameters_That_Were_Passed_Into_The_CreateTeam_Method(){
       var classroom = new Classroom();
       Dictionary<int, string> team = classroom.CreateTeam("first", "second", "third");

       Assert.NotNull(team);
       Assert.Equal(3, team.Count());

       var keys = team.Keys;
       Assert.Contains(1, keys);
       Assert.Contains(2, keys);
       Assert.Contains(3, keys);

       Assert.Equal("first", team[1]);
       Assert.Equal("second", team[2]);
       Assert.Equal("third", team[3]);
    }
}