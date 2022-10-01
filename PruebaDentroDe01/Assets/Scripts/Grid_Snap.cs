using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid_Snap : MonoBehaviour
{
    private Grid g_grid;

    // Start is called before the first frame update
    void Start()
    {
        g_grid = Grid.FindObjectOfType<Grid>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3Int cp = g_grid.LocalToCell(transform.position);
        transform.localPosition = g_grid.GetCellCenterLocal(cp);
    }
}
