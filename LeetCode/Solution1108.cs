public class Solution1108
{
    public string DefangIPaddr(string address)
    {
        var defangedIP = string.Empty;
        foreach (var c in address)
        {
            if (c == '.')
            {
                defangedIP += "[.]";
            }
            else
            {
                defangedIP += c;
            }
        }

        return defangedIP;
    }
    
    public string DefangIPaddr2(string address)
    {
        return address.Replace(".", "[.]");
    }
}
