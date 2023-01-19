using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace InsaneProject
{
    public class InsaneProject: MonoBehaviour
    {

        private bool MainMenu = true;
        public Rect RT_MainMenu = new Rect(0f, 100f, 120f, 100f);
        public int ID_RTMainMenu = 1;

        private MalakLevelManager levelManager = new MalakLevelManager();
        private float StunTime = 30f;

        private void Menu_MainMenu(int id)
        {
            if (GUILayout.Button("Frenzy all enemies", new GUILayoutOption[0]))
            {
                this.levelManager.frenzyAllEnemies();
            }
            if (GUILayout.Button("Reveal all enemies", new GUILayoutOption[0]))
            {
                this.levelManager.revealAllEnemies(true);
            }
            if (GUILayout.Button("Stuns all enemies for 30 seconds", new GUILayoutOption[0]))
            {
                this.levelManager.stunAllEnemies(this.StunTime);
            }

            if (GUILayout.Button("Collect all soul shards", new GUILayoutOption[0]))
            {
                int num = 289;
                for (int i = 0; i < num; i++)
                {
                    this.levelManager.getShard();
                }
            }
            GUI.DragWindow();
        }

        public void OnGUI()
        {
            GUI.Label(new Rect(10, 10, 100, 200), "Insane Project v0.1");
            if (this.MainMenu)
            {
                this.RT_MainMenu = GUILayout.Window(this.ID_RTMainMenu, this.RT_MainMenu, new GUI.WindowFunction(this.Menu_MainMenu), "Insane Project", new GUILayoutOption[0]);
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Insert))
            {
                this.MainMenu = !this.MainMenu;
            }
        }
    }
}
