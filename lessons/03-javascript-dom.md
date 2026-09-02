# JavaScript DOM basics

## Read an element

```js
const button = document.querySelector('#save');
```

## React to an event

```js
button.addEventListener('click', () => {
  console.log('Saved');
});
```

## Update the page

```js
const status = document.querySelector('#status');
status.textContent = 'Ready';
```

## A useful pattern

Keep application data in JavaScript state, then render the interface from that state. For small apps this is easier to reason about than changing unrelated elements everywhere.

```js
let tasks = [];

function render() {
  list.innerHTML = tasks.map(task => `<li>${task}</li>`).join('');
}
```

For user-provided text, prefer creating DOM nodes and assigning `textContent` instead of inserting raw HTML.
