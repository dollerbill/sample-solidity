pragma solidity ^0.4.2;

contract Modifiers
{
    address public owner;
    
    constructor() public {
        owner = msg.sender;
    }

    modifier onlyOwner {
        require(msg.sender == owner);
        _;
    }

    modifier notOwner {
        require(msg.sender != owner);
        _;
    }

    modifier isThis (address _addy) {
        require(msg.sender == _addy);
        _;
    }

    modifier notThis(address _addy) {
        require(msg.sender != _addy);
        _;
    }

    function isOwner() public onlyOwner returns (bool) {
        return true;
    }

    function isNotOwner() public notOwner returns (bool) {
        return true;
    }

    function isAddress(address _addy) public isThis(_addy) returns (bool) {
        return true;
    }

    function isNotAddress(address _addy) public notThis(_addy) returns (bool) {
        return true;
    }

    function bothMods(address _addy) public isThis(_addy) onlyOwner returns (bool) {
        return true;
    }

}