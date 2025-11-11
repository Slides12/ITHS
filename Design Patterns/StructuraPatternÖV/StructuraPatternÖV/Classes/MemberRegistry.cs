namespace StructuraPatternÖV.Classes
{
    public class MemberRegistry
    {
        private readonly HashSet<string> _members = new() { "Anna", "Bjorn", "Carina" };
        public bool RegisterMember(string memberName) => _members.Contains(memberName);

    }
}
