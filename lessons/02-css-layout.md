# CSS layout

## Flexbox

Best for arranging items in one main direction.

```css
.row {
  display: flex;
  gap: 1rem;
  align-items: center;
  justify-content: space-between;
}
```

## Grid

Best for two-dimensional layouts.

```css
.grid {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(220px, 1fr));
  gap: 1rem;
}
```

## Responsive sizing

Prefer flexible widths and a readable max width:

```css
.wrapper {
  width: min(1100px, calc(100% - 2rem));
  margin-inline: auto;
}
```

Use media queries only when the layout actually needs to change.
