import Link from 'next/link';
import styles from '../styles/Navbar.module.css';

const Navbar = () => {
  return (
    <nav className={styles.navbar}>
      <Link href="/cliente">Cliente</Link>
      <Link href="/passagem">Passagem</Link>
      <Link href="/compra">Compra</Link>
    </nav>
  );
};

export default Navbar;
