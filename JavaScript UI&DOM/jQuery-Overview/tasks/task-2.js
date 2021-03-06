/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 
*/
function solve() {
  var CONSTANTS = {
      selector: {
        button: '.button',
        content: '.content'
      },
      class: {
        content: 'content',
          button: 'button'
      },
      buttonInnerHTML: {
        onHidden: 'show',
        onVisible: 'hide'
      },
      display: {
        hidden: 'none',
        visible: ''
      }
    },
    validator = {
      getElement: function(selector) {
        if (typeof selector !== 'string' || !$(selector).size()) {
          throw new Error('Invalid selector');
        }

        return $(selector);
      }
    };

  var buttonEvent = function() {
    $(this).text(CONSTANTS.buttonInnerHTML.onVisible)
      .click(function() {
        var $clicked = $(this),
          $content;

        $content = $clicked.next(CONSTANTS.selector.content);
        if ($content.length && $content.nextAll(CONSTANTS.selector.button).length) {
          if ($content.css('display') === CONSTANTS.display.hidden) {
            $clicked.text('hide');
            $content.css('display', CONSTANTS.display.visible);
          } else {
            $clicked.text('show');
            $content.css('display', CONSTANTS.display.hidden);
          }
        }

      });
  };

  return function(selector) {
    validator.getElement(selector)
      .children(CONSTANTS.selector.button)
      .each(buttonEvent);
  };
}

module.exports = solve;