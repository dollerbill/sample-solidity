pragma solidity ^0.4.2;

contract Variables {

    string public biggestScope = "This is global";
    string private smallerScope;
    uint x = 64;
    uint y;
    address public owner;
    bool public yes = true;
    bool no;

    
    function globalVariable() public view returns (string) {
        return biggestScope;
    }

    function changeGlobal() public returns (string) {
        biggestScope = "This variable changed";
        return biggestScope;
    }

    function localVariable(string _smallerScope) public returns (string) {
        smallerScope = _smallerScope;
        return smallerScope;
    }
    
    function returnXVar() public view returns (uint) {
        return x;
    }

    function setReturnYVar(uint _y) public returns (uint) {
        y = _y;
        return y;
    }

    



}