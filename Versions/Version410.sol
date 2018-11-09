pragma solidity ^0.4.10;

contract Version410 {
    address owner;
    function Version410() {
    owner = msg.sender;
    }
    
    function v410Revert() public returns (bool) {
        if (msg.sender != owner) {
            return true;
        } else {
        revert();
        }
    }
}
