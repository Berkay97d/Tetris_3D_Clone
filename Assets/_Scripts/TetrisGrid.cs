using UnityEngine;

namespace DefaultNamespace
{
    public class TetrisGrid : MonoBehaviour
    {
        [SerializeField] private Vector3 gridStartPos;
        [SerializeField] private Grid grid;
        
        private int gridColumnCount = 10;
        private int gridRowCount = 20;
        private Grid[,] grids = new Grid[20, 10];


        private void Awake()
        {
            InitGridSystem();
        }
        
       
        private void InitGridSystem()
        {
            for (var row = 0; row < gridRowCount; row++)
            {
                for (var column = 0; column < gridColumnCount; column++)
                {
                    var pos = new Vector3(gridStartPos.x + (column * grid.GetGridSize().x), gridStartPos.y + (row * grid.GetGridSize().y),
                        gridStartPos.z);
                    var a = Instantiate(grid, pos, Quaternion.identity);
                    
                    a.transform.SetParent(transform);
                    
                    a.xIndex = row;
                    a.yIndex = column;
                    
                    a.name = row + "x" + column;
                    
                    grids[row, column] = a;
                }
            }
        }
        
    }
}