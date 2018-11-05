pragma solidity ^0.4.2;

contract Branches {

    address public owner;

    constructor () public {
        owner = msg.sender;
    }
    
    function multipleBranches(uint x, uint y, uint z) public pure returns (bool) {
        if (x > y) {
            if (y > z) {
                if (x == y + 1) {
                    if (y == z + 1) {
                        return true;
                    } revert();
                } revert();
            } revert();
        } revert();
    }
}