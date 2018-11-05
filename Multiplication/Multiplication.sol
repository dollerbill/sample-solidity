pragma solidity ^0.4.2;

contract Mul2Ints {
    event Multiply(uint256 product);
    uint amount;
    
    function mulTwoIntegers(uint first, uint second) public returns (uint) {
        amount = first * second;
        emit Multiply(amount);
        return amount;
    }

}