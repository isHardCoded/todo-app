import './Navbar.scss'
import NewspaperIcon from '../../../public/assets/icons/newspaper.svg'
import ClockIcon from '../../../public/assets/icons/clock.svg'
import TableIcon from '../../../public/assets/icons/table.svg'
import ClipboardIcon from '../../../public/assets/icons/clipboard-list.svg'

const Navbar = ({ handleClick }) => {
	return (
		<div className='navbar'>
			<nav>
				<ul>
					<li>
						<img src={NewspaperIcon} alt='' />
						<span>Доска</span>
					</li>
					<li>
						<img src={TableIcon} alt='' />
						<span>Таблица</span>
					</li>
				</ul>
			</nav>
			<button onClick={() => handleClick()}>Создать</button>
		</div>
	)
}

export default Navbar
