pragma solidity ^0.4.2;

contract FalseBoolean {
        
    function isFalse(uint x, uint y) public pure returns (bool) {
        if (x != y) {
            return false;
        }
        return true;
    }
}