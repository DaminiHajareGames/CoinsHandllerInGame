using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommonOfDamini.Coins
{
    public class Manager_Coin : MonoBehaviour
    {
        public static Manager_Coin instance;
        #region VARIABLES
        #region INSPECTOR_VARIABLES
        [Space(10)]
        [Header("<========= REFERENCES =======>")]
        [Space(3)]
        public int i;
        #endregion

        #region PUBLIC_VARIABLES
        #endregion

        #region PRIVATE_VARIABLES
        #endregion

        #region PROTECTED_VARIABLES
        #endregion

        #region GETTER/SETTER
        int _coins;
        int coins
        {
            get
            {
                return PlayerPrefs.GetInt("Coins", 0);
            }set
            {
                if (value < 0)
                    value = 0;
                PlayerPrefs.SetInt("Coins", value);
                UpdateCoinsUI();
            }
        }
        #endregion

        #region ENUMS
        #endregion

        #region CLASS
        #endregion

        #region STRUCT
        #endregion

        #region DELEGATE/EVENT
        public delegate void UpdateCoinsAction();
        public event UpdateCoinsAction updateCoinsEvent;
        
        #endregion
        #endregion

        #region METHODS
        #region UNITY_METHODS
        private void Awake()
        {
            if (instance == null)
                instance = this;
            else
                Destroy(this);
        }

        private void Start()
        {
            LoadCoins();
        }
        #endregion

        #region INIT_METHODS
        /// <summary>
        /// Add all values which will be initalized for once only
        /// </summary>
        void InitValues()
        {
        }

        /// <summary>
        /// Reset values at each game start, over
        /// </summary>
        void ResetValues() 
        {
        }

        /// <summary>
        /// On Play Mode Start
        /// </summary>
        public void OnPlayModeStart()
        {
            ResetValues();
        }

        /// <summary>
        /// On GameOver
        /// </summary>
        public void OnGameOver()
        {
            ResetValues();
        }
        #endregion

        #region ON_CLICK_METHODS
        #endregion

        #region SET_UI
        #endregion

        #region LOGIC_BASED_METHODS
        public int GetCurrentCoins()
        {
            return coins;
        }

        void LoadCoins()
        {
            UpdateCoinsUI();
        }

        public void AddCoins(int value)
        {
            coins += value;
        }

        public bool RemoveCoins(int value)
        {
            if (coins - value < 0)
                return false;

            coins -= value;
            return true;
        }

        void UpdateCoinsUI()
        {
            updateCoinsEvent?.Invoke();
        }
        #endregion
        #endregion

        #region COROUTINES
        #endregion
    }
}
