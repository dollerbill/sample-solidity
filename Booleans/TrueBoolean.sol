pragma solidity ^0.4.2;

contract TrueBoolean {
        
    function isTrue(uint x, uint y) public pure returns (bool) {
        if (x == y) {
            return true;
        }
        return false;
    }
}