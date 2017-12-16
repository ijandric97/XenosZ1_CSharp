using System;
using System.Text;
using System.Security.Cryptography;
using System.Management;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Net;

public class License
{
    private string ServerLink = "http://hexa-core.net/DesysBullshitSolution/XenosZ1.txt";
    private bool Verified = false;
    private string HWID = string.Empty;

    public License()
    {
        if (string.IsNullOrEmpty(HWID))
        {
            MD5("CPU: " + CpuId() +
                "\nBIOS: " + BiosId() +
                "\nBASE: " + BaseId() +
                "\nDISK: " + DiskId() +
                "\nVIDEO: " + VideoId() +
                "\nMAC: " + MacId());
        }
    }

    public void Verify()
    {
        WebClient webClient = new WebClient();
        try
        {
            string stringResponse = webClient.DownloadString(ServerLink);
            if (stringResponse.Contains(HWID))
            {
                Verified = true;
            }
        }
        catch (Exception )
        {
            Verified = false;
            MessageBox.Show("Server Error", "Unable to verify HWID.");
        }  
    }

    public bool GetVerified()
    {
        return Verified;
    }

    public string GetHWID()
    {
        return HWID;
    }

    private void MD5(string str)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(str);
        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        bytes = md5.ComputeHash(bytes);
        HWID = BitConverter.ToString(bytes).Replace("-", "");
    }

    #region WMI
    private string Identifier(string wmiClass, string wmiProperty)
    {
        string result = "";
        ManagementClass managementClass = new ManagementClass(wmiClass);
        ManagementObjectCollection managementObjectCollection = managementClass.GetInstances();
        foreach (ManagementObject managementObject in managementObjectCollection)
        {
            //Only get the first one
            if (result == "")
            {
                try
                {
                    result = managementObject[wmiProperty].ToString();
                    break;
                }
                catch
                {
                }
            }
        }
        return result;
    }

    private string Identifier (string wmiClass, string wmiProperty, string wmiMustBeTrue)
    {
        string result = "";
        ManagementClass managementClass = new ManagementClass(wmiClass);
        ManagementObjectCollection managementObjectCollection = managementClass.GetInstances();
        foreach (ManagementObject managementObject in managementObjectCollection)
        {
            if (managementObject[wmiMustBeTrue].ToString() == "True")
            {
                if (result == "") //Only get the first one
                {
                    try
                    {
                        result = managementObject[wmiProperty].ToString();
                        break;
                    }
                    catch
                    {
                    }
                }
            }
        }
        return result;
    }

    private string CpuId()
    {
        string retVal = Identifier("Win32_Processor", "UniqueId"); //Uses first CPU Identifier available, to save on performance
        if (retVal == "") //If no UniqueID, use ProcessorID
        {
            retVal = Identifier("Win32_Processor", "ProcessorId");
            if (retVal == "") //If no ProcessorId, use Name
            {
                retVal = Identifier("Win32_Processor", "Name");
                if (retVal == "") //If no Name, use Manufacturer
                {
                    retVal = Identifier("Win32_Processor", "Manufacturer");
                }
                retVal += Identifier("Win32_Processor", "MaxClockSpeed"); //Add clock speed for extra security
            }
        }
        return retVal;
    }

    private string BiosId() //BIOS Identifier
    {
        return Identifier("Win32_BIOS", "Manufacturer") +
            Identifier("Win32_BIOS", "SMBIOSBIOSVersion") +
            Identifier("Win32_BIOS", "IdentificationCode") +
            Identifier("Win32_BIOS", "SerialNumber") +
            Identifier("Win32_BIOS", "ReleaseDate") +
            Identifier("Win32_BIOS", "Version");
    }

    private string DiskId()
    {
        return Identifier("Win32_DiskDrive", "Model") +
            Identifier("Win32_DiskDrive", "Manufacturer") +
            Identifier("Win32_DiskDrive", "Signature") +
            Identifier("Win32_DiskDrive", "TotalHeads");
    }

    private string BaseId() //Motherboard ID
    {
        return Identifier("Win32_BaseBoard", "Model") +
            Identifier("Win32_BaseBoard", "Manufacturer") +
            Identifier("Win32_BaseBoard", "Name") +
            Identifier("Win32_BaseBoard", "SerialNumber");
    }

    private string VideoId() //Primary video controller ID
    {
        return Identifier("Win32_VideoController", "DriverVersion") +
            Identifier("Win32_VideoController", "Name");
    }

    private string MacId() //First enabled network card ID
    {
        return Identifier("Win32_NetworkAdapterConfiguration", "MACAddress", "IPEnabled");
    }
    #endregion
}