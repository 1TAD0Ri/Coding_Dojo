// import React from 'react'
type GreetProps = {
    name: string
    messageCount?: number
    isLoggedIn: boolean
}

export default function Greet(props: GreetProps) {
    const {messageCount = 0 } = props
    return (
        <h1>{ props.isLoggedIn ?  `Welcome ${props.name} ! You have ${props.messageCount} unread messages`  : "Welcome guest" }</h1>
    )
}
