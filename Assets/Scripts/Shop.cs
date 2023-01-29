using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] TurretBlueprint ballistaTurret;

    BuildManager buildManager;
    private void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void SelectBallista()
    {
        buildManager.SelectTurretToBuild(ballistaTurret);
    }
}
