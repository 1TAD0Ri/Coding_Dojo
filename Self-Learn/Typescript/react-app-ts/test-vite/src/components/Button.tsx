
type ButtonProps = {
    handleClick: (e: React.MouseEvent<HTMLButtonElement> , id: number)=> void
}


export default function Button(props: ButtonProps) {
  return  <button onClick={e =>props.handleClick(e, 1)}>Click</button>
}
