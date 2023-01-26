using UnityEngine;

public static class PlayerPrefs
{
  

    #region CustomPlayerPrefs
    
    
    
    
    #region Boolean
    public static void SetBool(string key, bool value)
    {
            int intValue = value ? 1 : 0;
            PlayerPrefs.SetInt(key, intValue);
    }
    
    public static bool GetBool(string key)
    {
       int intValue = PlayerPrefs.GetInt(key);
       return intValue == 1 ? true : false;
    }
    #endregion Boolean
    
    #region Vector2
    public static void SetVector2(string key, Vector2 value)
    {
        PlayerPrefs.SetFloat(key + "x", value.x);
        PlayerPrefs.SetFloat(key + "y", value.y);
    }

    public static Vector2 GetVector2(string key)
    {
        Vector2 value = new Vector2();
        value.x = PlayerPrefs.GetFloat(key + "x");
        value.y = PlayerPrefs.GetFloat(key + "y");
        return value;
    }
    #endregion Vector2
    
    #region Vector3
    public static void SetVector3(string key, Vector3 value)
    {
        PlayerPrefs.SetFloat(key + "x", value.x);
        PlayerPrefs.SetFloat(key + "y", value.y);
        PlayerPrefs.SetFloat(key + "z", value.z);
    }

    public static Vector3 GetVector3(string key)
    {
        Vector3 value = new Vector3();
        value.x = PlayerPrefs.GetFloat(key + "x");
        value.y = PlayerPrefs.GetFloat(key + "y");
        value.z = PlayerPrefs.GetFloat(key + "z");
        return value;

    }
    #endregion Vector3
    
  
   
   
        
        
    #endregion CustomPlayerPrefs
        
    #region Original PlayerPrefs
        public static void SetInt(string key, int value)
        {
            UnityEngine.PlayerPrefs.SetInt(key, value);
        }
        
        public static int GetInt(string key)
        {
            return  UnityEngine.PlayerPrefs.GetInt(key);
        }
        
        public static void SetFloat(string key, float value)
        {
            UnityEngine.PlayerPrefs.SetFloat(key, value);
        }
        
        public static float GetFloat(string key)
        {
            return  UnityEngine.PlayerPrefs.GetFloat(key);
        }
        
        public static void SetString(string key, string value)
        {
            UnityEngine.PlayerPrefs.SetString(key, value);
        }
        
        public static string GetString(string key)
        {
            return UnityEngine.PlayerPrefs.GetString(key);
        }
        
        public static void DeleteKey(string key)
        {
            UnityEngine.PlayerPrefs.DeleteKey(key);
        }
        
        public static void DeleteAll()
        {
            UnityEngine.PlayerPrefs.DeleteAll();
        }
        
        public static bool HasKey(string key)
        {
            return UnityEngine.PlayerPrefs.HasKey(key);
        }
        
        public static void Save()
        {
            UnityEngine.PlayerPrefs.Save();
        }
        
        
        #endregion Original PlayerPrefs
    
    
    
    
    

}
