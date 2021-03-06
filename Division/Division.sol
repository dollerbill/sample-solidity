pragma solidity ^0.4.2;

contract Division {
    event Divide(uint256 quotient);
    uint amount;
    
    function divTwoIntegers(uint first, uint second) public returns (uint) {
        amount = first / second;
        emit Divide(amount);
        return amount;
    }

}