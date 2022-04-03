namespace App.Con
{
    public struct StudentStruct
    {
        public string Name;
        public string Address;
        public string Email;

        public StudentStruct(string name, string address, string email)
        {
            Name = name;
            Address = address;
            Email = email;
        }

        public void Clear()
        {
            Name = string.Empty;
            Address = string.Empty;
            Email = string.Empty;
        }
    }
}