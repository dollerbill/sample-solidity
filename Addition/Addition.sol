pragma solidity ^0.4.2;

contract Addition {
    event Adding(uint256 sum);
    uint amount;
    
    function addTwoIntegers(uint first, uint second) public returns (uint) {
        amount = first + second;
        emit Adding(amount);
        return amount;
    }

}