using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveSystem
{
    //SCORE
    public static void SaveData(detectClock player)
    {
        string path = Application.persistentDataPath + "/ClockData.This";
        BinaryFormatter x = new BinaryFormatter();
        FileStream stram = new FileStream(path, FileMode.Create);

        GameData data = new GameData(player);

        x.Serialize(stram, data);
        stram.Close();
        Debug.Log("simpan Baru");

    }
    public static GameData LoadData()
    {
        string path = Application.persistentDataPath + "/ClockData.This";
        if (File.Exists(path))
        {
            BinaryFormatter x = new BinaryFormatter();
            FileStream stram = new FileStream(path, FileMode.Open);

            GameData data = x.Deserialize(stram) as GameData;
            stram.Close();
            Debug.Log("load");
            return data;

        }else
        {
            Debug.Log("unload");
            return null;
        }
    }
}
