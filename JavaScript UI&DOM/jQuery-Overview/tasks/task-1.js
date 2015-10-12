/* globals $ */

/* 
Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:   
  * The UL must have a class `items-list`
  * Each of the LIs must:
    * have a class `list-item`
    * content "List item #INDEX"
      * The indices are zero-based
  * If the provided selector does not selects anything, do nothing
  * Throws if
    * COUNT is a `Number`, but is less than 1
    * COUNT is **missing**, or **not convertible** to `Number`
      * _Example:_
        * Valid COUNT values:
          * 1, 2, 3, '1', '4', '1123'
        * Invalid COUNT values:
          * '123px' 'John', {}, [] 
*/

function solve() {
  var CONSTANTS = {
    ul: {
      class: 'items-list'
    },
    li: {
      class: 'list-item',
      content: 'List item #'
    }
  };

  var validator = {
    validateSelector: function(selector) {
      if (typeof selector !== 'string') {
        throw new Error('Selector must be of type string');
      }
    },
    validateCount: function(count) {
      if (count === null || count !== Number(count)) {
        throw new Error('Count must be a number');
      }

      count = +count;

      if (count < 1) {
        throw new Error('Count must be bigger than 1');
      }

      return count;
    }
  };

  function generateUl(count) {
    var i,
      $li,
      $ul = $('<ul />').addClass(CONSTANTS.ul.class);

    for (i = 0; i < count; i += 1) {
      $li = $('<li />')
        .addClass(CONSTANTS.li.class)
        .text(CONSTANTS.li.content + i)
        .appendTo($ul);
    }

    return $ul;
  }

  return function(selector, count) {
    validator.validateSelector(selector);
    count = validator.validateCount(count);

    generateUl(count).appendTo(selector);
  };
};

module.exports = solve;