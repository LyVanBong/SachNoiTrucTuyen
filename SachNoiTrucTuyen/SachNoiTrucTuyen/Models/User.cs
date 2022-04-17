using System.Linq;

namespace SachNoiTrucTuyen.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public int IdA { get; set; }
        public string Description { get; set; }
        public int AmountFollow { get; set; }
        public int AmountPost { get; set; }
        public int AmountLike { get; set; }
        public int ScoreInGame { get; set; }
        public int ScoreOfGame { get; set; }
        public Armorial Armorial => App.Armorials.FirstOrDefault(a => a.Id == IdA);
        public bool IsFollow { get; set; }
    }
}