enum Direction {  
    East,  
    West,  
    North,  
    South      
};  
var dir = Direction.North;  
  
function getDirection() {  
    switch (dir) {  
        case Direction.North: console.log('You are in North Direction');  
            break;  
        case Direction.East: console.log('You are in East Direction');  
            break;  
        case Direction.South: console.log('You are in South Direction');  
            break;  
        case Direction.West: console.log('You are in West Direction');  
            break;  
    }  
}  
getDirection();