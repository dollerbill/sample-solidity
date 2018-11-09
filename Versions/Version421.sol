pragma solidity ^0.4.21;

contract Version421 {
    address public owner; 
    uint public version;

    function Version421 (uint _version) public {
        version = _version;
    }

    function v421Returns() public view returns (uint) {
        
        return version;
    }

}