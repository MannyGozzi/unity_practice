using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateCompleteVisual : MonoBehaviour
{
    public struct KitchenObjectSO_GameObject {
        public KitchenObjectSO kitchenObjectSO;
        public KitchenObjectSO_GameObject gameObject;
    }
     
    [SerializeField] private PlateKitchenObject plateKitchenObject;
    private void Start() {
        plateKitchenObject.OnIngredientAdded += PlateKitchenObject_OnIngredientAdded;
    }

    private void PlateKitchenObject_OnIngredientAdded(object sender, PlateKitchenObject.OnIngredientsAddedEventArgs e) {
        Debug.Log("PlateCompleteVisual: " + e.kitchenObjectSO.name);
    }
}
