pragma solidity ^0.4.2;

import "./Interfaces/IInheritance.sol";
import "./Modifiers.sol";


contract Inheritance is IInheritance, Modifiers {

    address public owner;
    
    constructor() public {
        owner = msg.sender;
    }

    event Returned(address from, bool returned);

        
    function returnsTrue() public returns (bool result) {
        result = true;
        emit Returned(msg.sender, result);
        return true;

    }
}