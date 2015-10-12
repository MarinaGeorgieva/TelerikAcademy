function solve() {
	var CONSTANTS = {
		selector: {
			createDiv: '<div />'
		},
		option: {
			default: 'Select a value'
		},
		class: {
			dropdownDiv: 'dropdown-list',
				current: 'current',
				optionsContainer: 'options-container',
				dropdownItem: 'dropdown-item'
		}
	};

	return function(selector) {
		var $dropdown = $(CONSTANTS.selector.createDiv)
			.addClass(CONSTANTS.class.dropdownDiv),
			$select = $(selector)
			.hide()
			.appendTo($dropdown),
			$currentOption = $(CONSTANTS.selector.createDiv)
			.addClass(CONSTANTS.class.current)
			.text(CONSTANTS.option.default)
			.appendTo($dropdown),
			$optionsContainer = $(CONSTANTS.selector.createDiv)
			.addClass(CONSTANTS.class.optionsContainer)
			.css('position', 'absolute')
			.hide()
			.appendTo($dropdown);


		$select.find('option').each(function(index) {
			var $this = $(this);

			$(CONSTANTS.selector.createDiv)
				.appendTo($optionsContainer)
				.addClass(CONSTANTS.class.dropdownItem)
				.attr('data-value', $this.val())
				.attr('data-index', index)
				.text($this.text())
				.click(function() {
					$currentOption.val($this.val());
					$currentOption.text($this.text());
					$optionsContainer.hide();

					$select.val($this.val());
				});
		});

		$currentOption.click(function() {
			$optionsContainer.toggle();
			$currentOption.text('Select a value');
		});

		$('body').append($dropdown);
	};
}

module.exports = solve;