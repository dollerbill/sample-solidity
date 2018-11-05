pragma solidity ^0.4.2;

contract Public
{
    string helloString = "Hello";

    function publicFunction() public returns (string) {
        return helloString;
    }

}