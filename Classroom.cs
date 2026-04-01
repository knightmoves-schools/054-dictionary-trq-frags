namespace knightmoves;

public class Classroom{

    public Dictionary<int, string> CreateTeam(string first, string second, string third){
        return new Dictionary<int, string> {
            {1, first},
            {2, second},
            {3, third}
        };
    }
}