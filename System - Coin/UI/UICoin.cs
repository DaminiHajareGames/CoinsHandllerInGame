using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace CommonOfDamini.Coins
{
    public class UICoin : MonoBehaviour
    {
        #region VARIABLES
        #region INSPECTOR_VARIABLES

        #endregion

        #region PUBLIC_VARIABLES
        #endregion

        #region PRIVATE_VARIABLES
        TextMeshProUGUI _coinsText;
        RectTransform _parentRectTransform;
        #endregion

        #region PROTECTED_VARIABLES
        #endregion

        #region GETTER/SETTER
        #endregion

        #region ENUMS
        #endregion

        #region CLASS
        #endregion

        #region STRUCT
        #endregion

        #region DELEGATE/EVENT
        #endregion
        #endregion

        #region METHODS
        #region UNITY_METHODS
        private void Awake()
        {
            _coinsText = GetComponent<TextMeshProUGUI>();
            _parentRectTransform = transform.parent.GetComponent<RectTransform>();
        }
        private void OnEnable()
        {
            Manager_Coin.instance.updateCoinsEvent += UpdateCoinUI;
            UpdateCoinUI();
        }
        private void OnDisable()
        {
            Manager_Coin.instance.updateCoinsEvent -= UpdateCoinUI;
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
        void UpdateCoinUI()
        {
            _coinsText.text = Manager_Coin.instance.GetCurrentCoins() +"";

            LayoutRebuilder.ForceRebuildLayoutImmediate(_parentRectTransform);
            
        }
        #endregion
        #endregion

        #region COROUTINES
        #endregion
    }
}
