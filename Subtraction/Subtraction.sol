pragma solidity ^0.4.2;

contract Subtract2Ints {
    event Subtracting(uint256 difference);
    uint amount;
    
    function diffTwoIntegers(uint first, uint second) public returns (uint) {
        amount = first - second;
        emit Subtracting(amount);
        return amount;
}

}