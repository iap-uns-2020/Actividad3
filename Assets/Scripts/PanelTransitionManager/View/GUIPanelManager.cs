using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PanelTransitionManager.View
{
	public class GUIPanelManager : MonoBehaviour, IGUIPanelManager
	{
		public GameObject mainPanel;
		public GameObject playerPanel;
		public GameObject QRCodeReaderPanel;
		private Stack<GameObject> panelStack;

		void Start()
		{
			panelStack = new Stack<GameObject>();
			panelStack.Push(mainPanel);
		}

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Escape))
				Back();
		}

		public void PlayButtonListener()
		{
			NewPanel(playerPanel);
		}

		public void AddNewLevelListener()
		{
			NewPanel(QRCodeReaderPanel);
		}

		private void NewPanel(GameObject panel)
		{
			panelStack.Peek().SetActive(false);
			panelStack.Push(panel);
			panelStack.Peek().SetActive(true);
		}

		private void Back()
		{
			GameObject currentPanel = panelStack.Peek();
			if (currentPanel.Equals(mainPanel))
				Application.Quit();
			else
			{
				currentPanel.SetActive(false);
				panelStack.Pop();
				panelStack.Peek().SetActive(true);
			}
		}


	}
}
