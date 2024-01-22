type HeadingProps = {
    children: string 
}
export default function Heading(props: HeadingProps) {
  return (
    <div><h2>  {props.children} </h2></div>
  )
}
