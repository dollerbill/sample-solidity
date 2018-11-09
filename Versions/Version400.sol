pragma solidity ^0.4.0;

contract Version400 {
    address owner;

    function Version400() {
        owner = msg.sender;
    }
    
    function v400Throw() returns (bool) { 
        if (msg.sender != owner) { throw; }
        return true;
    }
}