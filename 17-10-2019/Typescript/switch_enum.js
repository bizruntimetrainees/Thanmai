var Direction;
(function (Direction) {
    Direction[Direction["East"] = 0] = "East";
    Direction[Direction["West"] = 1] = "West";
    Direction[Direction["North"] = 2] = "North";
    Direction[Direction["South"] = 3] = "South";
})(Direction || (Direction = {}));
;
var dir = Direction.North;
function getDirection() {
    switch (dir) {
        case Direction.North:
            console.log('You are in North Direction');
            break;
        case Direction.East:
            console.log('You are in East Direction');
            break;
        case Direction.South:
            console.log('You are in South Direction');
            break;
        case Direction.West:
            console.log('You are in West Direction');
            break;
    }
}
getDirection();
