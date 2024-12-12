namespace ClassAdapter
{
    /// <summary>
    /// Helper class we need (not part of the pattern structure)
    /// </summary>
    public class CityFromExternalSystem
    {
        public string Name { get; private set; }
        public string NickName { get; private set; }
        public int Inhabitants { get; private set; }

        public CityFromExternalSystem(string name, string nickName, int inhabitants)
        {
            Name = name;
            NickName = nickName;
            Inhabitants = inhabitants;
        }
    }

    /// <summary>
    /// Adaptee
    /// </summary>
    public class ExternalSystem
    {
        public CityFromExternalSystem GetCity()
        {
            return new CityFromExternalSystem("Antwerp", "'t Stad", 500000);
        }
    }

    /// <summary>
    /// Helper class we need (not part of the pattern structure)
    /// </summary>
    public class City
    {
        public string Fullname { get; private set; }
        public long Inhabitants { get; private set; }

        public City(string fullname, long inhabitants)
        {
            Fullname = fullname;
            Inhabitants = inhabitants;
        }
    }

    /// <summary>
    /// Target
    /// </summary>
    public interface ICityAdapter
    {
        City GetCity();
    }

    /// <summary>
    /// Adapter
    /// </summary>
    public class CityAdapter : ExternalSystem, ICityAdapter
    {
        public City GetCity()
        {
            // call into the external system
            var cityFromExternalSystem = base.GetCity();

            // adapt the CityFromExternalSystem to City
            return new City($"{cityFromExternalSystem.Name} - {cityFromExternalSystem.NickName}", cityFromExternalSystem.Inhabitants);
        }
    }
}
