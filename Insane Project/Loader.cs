using UnityEngine;

namespace InsaneProject
{
    internal class Loader
    {
        public static void Load()
        {
            InsaneProject insaneProject = new InsaneProject();
            Loader.MainClass = new GameObject("fl_main");
            Loader.MainClass.AddComponent<InsaneProject>();
            UnityEngine.Object.DontDestroyOnLoad(Loader.MainClass);
            for (int i = 0; i < 50; i++)
            {
                Debug.Log("");
            }
        }
        public static GameObject MainClass;
    }
}
